import React, { useEffect, useState } from "react";
import { Card, CardBody, CardTitle, CardText, Container, Row, Col } from "reactstrap";
import { getBlogs } from "../managers/BlogManager";
import "./Blog.css";
import { Link } from "react-router-dom";

export default function Blogs() {
    const [blogs, setBlogs] = useState([]);

    useEffect(() => {
        getBlogs().then(setBlogs);
    }, []);

    return (
        <Container className="blog-container py-5">
            <h2 className="text-center mb-4">Latest Blogs</h2>
            <Row>
                {blogs.map((b) => (
                    <Col md={6} lg={4} key={b.id} className="mb-4">
                        <Card className="blog-card">
                            <CardBody>
                                <Link to={`/blog/${b.id}`} className="blog-card-title-link">
                                <CardTitle tag="h5" className="blog-card-title">{b.title}</CardTitle>
                                </Link>
                                <CardText className="blog-card-text">{b.content.substring(0, 100)}...</CardText>
                                <CardText>
                                    <small className="text-muted">Posted on: {new Date(b.postDate).toLocaleDateString()}</small>
                                </CardText>     
                            </CardBody>
                        </Card>
                    </Col>
                ))}
            </Row>
        </Container>
    );
}
