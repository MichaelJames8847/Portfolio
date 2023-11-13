export function VideoModal({ show, onClose, videoUrl }) {
    if (!show) {
        return null;
    }

    // Ensure that the videoUrl is a proper embed URL
    // It should be similar to the src attribute in the embed code provided by Loom

    return (
        <div className="modal-overlay">
            <div className="modal-content">
                <button onClick={onClose}>Close</button>
                <div style={{position: 'relative', paddingBottom: '56.25%', height: 0}}>
                    <iframe 
                        src={videoUrl} 
                        title="Demo Project"
                        style={{position: 'absolute', top: 0, left: 0, width: '100%', height: '100%'}}
                        allowFullScreen>
                    </iframe>
                </div>
            </div>
        </div>
    );
}
