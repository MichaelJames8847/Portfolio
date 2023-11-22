import { useState } from "react";
import { createBlog } from "../managers/BlogManager";
import { useNavigate } from "react-router-dom";
import { Button, Container, Form, FormGroup, Input, Label } from "reactstrap";
import "./CreateBlog.css";

export default function CreateBlog() {
    const [blog, setBlog] = useState({
        title: "",
        content: "",
        postDate: new Date().toISOString(),
        image: ""
    });

    const navigate = useNavigate();

    const handleChange = (e) => {
        setBlog({ ...blog, [e.target.name]: e.target.value });
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        try {
            await createBlog(blog).then(() => {
                navigate("/blog");
            })
        }
        catch (error) {
            return console.log(error)
        }
    };

    return (
        <Container className="create-blog-container">
            <h2>Create a New Blog Post</h2>
            <Form onSubmit={handleSubmit} className="blog-form">
                <FormGroup>
                    <Label for="title">Title</Label>
                    <Input
                        type="text"
                        name="title"
                        id="title"
                        value={blog.title}
                        onChange={handleChange}
                        required
                    />
                </FormGroup>

                <FormGroup>
                    <Label for="content">Content</Label>
                    <Input
                        type="textarea"
                        name="content"
                        id="content"
                        value={blog.content}
                        onChange={handleChange}
                        required
                    />
                </FormGroup>

                <FormGroup>
                    <Label for="image">Image URL</Label>
                    <Input
                        type="text"
                        name="image"
                        id="image"
                        value={blog.image}
                        onChange={handleChange}
                    />
                </FormGroup>

                <Button type="submit" color="primary">Create Blog</Button>
            </Form>
        </Container>
    );
}