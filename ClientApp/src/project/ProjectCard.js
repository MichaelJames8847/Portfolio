export default function ProjectCard({ project }) {
    return (
        <div className="project-card">
            <img src={project.image} alt={project.title} className="project-image" />
            <h3>{project.title}</h3>
            <p>{project.description}</p>
            <div className="project-details">
                <span>Began: {new Date(project.startDate).toLocaleDateString()}</span>
                <span>Finished: {new Date(project.endDate).toLocaleDateString()}</span>
            </div>
            <a href={project.link} target="_blank" rel="noopener noreferrer" className="btn btn-primary">Github Repo</a>
            <div className="project-status">Status: {project.projectStatus}</div>
        </div>
    )
}