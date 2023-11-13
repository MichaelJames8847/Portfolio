// Home.js
import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { Container, Row, Col } from 'reactstrap';
import './Home.css'; // Import your CSS file
import { getUserProfile } from '../managers/UserProfileManager';
import { getTechnologies } from '../managers/technologyManager';

export function Home() {
    const [technologies, setTechnologies] = useState([]);
    const [user, setUser] = useState({});

    useEffect(() => {
        // Assuming getUserProfile() and getTechnologies() return data correctly
        // Update these calls as necessary
        getUserProfile().then(data => setUser(data[0]));
        getTechnologies().then(setTechnologies);
    }, []);

    return (
        <Container fluid className="home">
            {/* Hero Section */}
            <Row className="hero-section">
                <Col className="text-center">
                    <img src={user.profilePic} alt="Michael James" className="hero-headshot" />
                    <h1>Michael James: Software Engineer</h1>
                    <p>Transforming Ideas into Digital Solutions</p>
                    <Link to="/project" className="btn btn-primary">View My Work!</Link>
                </Col>
            </Row>

            {/* About Me Section */}
            <Row className="about-me-section">
                <Col>
                    <h2>Gamer, Coder, Chef</h2>
                    <p>A unique blend of creativity, culinary arts, and coding.</p>
                </Col>
            </Row>

            {/* Tech Stack */}
            <Row className="tech-stack">
                <Col>
                    <h2>Tech Stack</h2>
                    <Row>
                        {technologies.map((tech, index) => (
                            <Col key={index} md={4} className="tech-item">
                                <p>{tech.technologyName}</p>
                            </Col>
                        ))}
                    </Row>
                </Col>
            </Row>

            {/* Contact Information */}
            <Row className="contact-info">
                <Col className="text-center">
                    <p>Email: {user.email}</p>
                    <p>Phone: {user.phoneNumber}</p>
                    <p>LinkedIn: <a href={user.linkedIn}>LinkedIn</a></p>
                    <p>GitHub: <a href={user.github}>GitHub</a></p>
                </Col>
            </Row>
        </Container>
    );
}
