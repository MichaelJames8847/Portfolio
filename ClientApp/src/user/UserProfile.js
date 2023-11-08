import { useEffect, useState } from "react";
import { Table } from "reactstrap";
import { getUserProfile } from "../managers/UserProfileManager";


export default function UserProfileView() {
    const [userProfile, setUserProfile] = useState([]);

    useEffect(() => {
        getUserProfile().then(setUserProfile)
    }, [])

    return (
        <div className="user-profile-view">
            <Table>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Profile Pic</th>
                        <th>Bio</th>
                        <th>Email</th>
                        <th>Phone</th>
                        <th>LinkedIn</th>
                        <th>GitHub</th>
                    </tr>
                </thead>
                <tbody>
                    {userProfile.map((up) => (
                        <tr key={up.id}>
                            <td>{`${up.firstName} ${up.lastName}`}</td>
                            <td>
                                <img src={up.profilePic} alt="Profile" />
                            </td>
                            <td>{up.bio}</td>
                            <td>{up.email}</td>
                            <td>{up.phoneNumber}</td>
                            <td>
                                <a href={up.linkedIn} target="_blank" rel="noopener noreferrer">
                                    LinkedIn
                                </a>
                            </td>
                            <td>
                                <a href={up.github} target="_blank" rel="noopener noreferrer">
                                    GitHub
                                </a>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </div>
    );
}
