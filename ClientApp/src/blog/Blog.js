import React, { useEffect, useState } from "react";
import { Card, CardBody, CardTitle, CardText, Container, Row, Col } from "reactstrap";
import { getBlogs } from "../managers/BlogManager";
import "./Blog.css";

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
                                <CardTitle tag="h5" className="blog-card-title">{b.title}</CardTitle>
                                <CardText className="blog-card-text">{b.content.substring(0, 100)}...</CardText>
                                <CardText>
                                    <small className="text-muted">Posted on: {new Date(b.postDate).toLocaleDateString()}</small>
                                </CardText>
                                {/* Add link to full blog post if applicable */}
                            </CardBody>
                        </Card>
                    </Col>
                ))}
            </Row>
        </Container>
    );
}
