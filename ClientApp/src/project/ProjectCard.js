import { useState } from "react"
import { VideoModal } from "../modal/DemoModal";

export default function ProjectCard({ project }) {
    const [showModal, setShowModal] = useState(false);

    const handleOpenModal = () => setShowModal(true);
    const handleCloseModal = () => setShowModal(false);

    // Use the GIF URL as a thumbnail
    const gifUrl = "https://cdn.loom.com/sessions/thumbnails/8cefd393719347a28ee318e221b7b386-with-play.gif";

    return (
        <div className="project-card">
            <img src={project.image} alt={project.title} className="project-image" />
            <h3>{project.title}</h3>
            <p>{project.description}</p>
            <div className="project-details">
                <span>Began: {new Date(project.startDate).toLocaleDateString()}</span>
                <span>Finished: {project.endDate ? new Date(project.endDate).toLocaleDateString() : 'Ongoing'}</span>
            </div>
            <a href={project.link} target="_blank" rel="noopener noreferrer" className="btn btn-primary">GitHub Repo</a>
            
            {project.demo && (
                <img 
                    src={gifUrl} 
                    alt="Demo Thumbnail" 
                    className="demo-thumbnail"
                    onClick={handleOpenModal} 
                />
            )}

            <VideoModal show={showModal} onClose={handleCloseModal} videoUrl={project.demo} />

            <div className="project-status">Status: {project.projectStatus}</div>
        </div>
    );
}
