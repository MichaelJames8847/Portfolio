// Projects.js
import React, { useEffect, useState } from 'react';
import { getProjects } from '../managers/projectManager';
import ProjectCard from './ProjectCard';
import "./Projects.css"

export default function Projects() {
    const [projects, setProjects] = useState([]);

    useEffect(() => {
        getProjects().then(setProjects);
    }, []);

    return (
        <div className="projects-page">
            <div className="projects-grid">
                {projects.map(project => (
                    <ProjectCard key={project.id} project={project} />
                ))}
            </div>
        </div>
    );
}
