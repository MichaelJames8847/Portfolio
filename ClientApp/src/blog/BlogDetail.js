import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Card, CardBody, CardTitle, CardText, Container, Media, Badge } from "reactstrap";
import { getBlogById } from "../managers/BlogManager";
import "./BlogDetail.css";

export default function BlogDetail() {
    const [blog, setBlog] = useState(null);
    const { id } = useParams();

    useEffect(() => {
        getBlogById(id).then(data => {
            if (data) {
                setBlog(data);
            } else {
                // Handle the case where blog data is not found
                console.log("Blog not found");
            }
        });
    }, [id]);

    if (!blog) {
        return <div>Loading...</div>;
    }

    return (
        <Container className="blog-detail-container py-5">
            <Card>
                <CardBody>
                    <CardTitle tag="h3">{blog.title}</CardTitle>
                    {blog.image && <Media src={blog.image} alt={blog.title} className="blog-image mb-3" />}
                    <CardText>{blog.content}</CardText>
                    <CardText>
                        <small className="text-muted">Posted on: {new Date(blog.postDate).toLocaleDateString()}</small>
                    </CardText>
                    <div className="blog-categories">
                        {blog.blogCategories && blog.blogCategories.map((cat, index) => (
                            <Badge key={index} color="primary" className="mr-2">{cat.categoryName}</Badge>
                        ))}
                    </div>
                    <div className="blog-interests mt-3">
                        {blog.blogInterests && blog.blogInterests.map((interest, index) => (
                            <Badge key={index} color="secondary" className="mr-2">{interest.name}</Badge>
                        ))}
                    </div>
                </CardBody>
            </Card>
        </Container>
    );
}
