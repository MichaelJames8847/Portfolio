import React, { useEffect, useState } from "react";
import { Card, CardBody, Container, Row, Col, Media } from "reactstrap";
import { getUserProfile } from "../managers/UserProfileManager";
import "./UserProfile.css";

export default function UserProfileView() {
    const [userProfile, setUserProfile] = useState(null);

    useEffect(() => {
        getUserProfile().then(data => setUserProfile(data[0]));
    }, []);

    return (
        <Container className="user-profile-view py-5">
            {userProfile && (
                <Row>
                    <Col md={11} className="text-center">
                        <Media object src={userProfile.profilePic} alt="Profile Picture" className="profile-pic" />
                    </Col>
                    <Col md={15}>
                        <Card className="profile-card">
                            <CardBody>
                                <h1 className="profile-name">{`${userProfile.firstName} ${userProfile.lastName}`}</h1>
                                <p className="profile-bio">{userProfile.bio}</p>
                                <p className="profile-detail">Email: {userProfile.email}</p>
                                <p className="profile-detail">Phone: {userProfile.phoneNumber}</p>
                                <p className="profile-detail">LinkedIn: <a href={userProfile.linkedIn} target="_blank" rel="noopener noreferrer">{userProfile.linkedIn}</a></p>
                                <p className="profile-detail">GitHub: <a href={userProfile.github} target="_blank" rel="noopener noreferrer">{userProfile.github}</a></p>
                            </CardBody>
                        </Card>
                    </Col>
                </Row>
            )}
        </Container>
    );
}
