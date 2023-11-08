import { useEffect, useState } from "react";
import { getBlogs } from "../managers/BlogManager";
import { Table } from "reactstrap";

export default function Blogs() {
    const [blogs, setBlogs] = useState([]);

    useEffect(() => {
        getBlogs().then(setBlogs)
    }, []);

    return (
        <>
        <div className="blog-view">
            <Table>
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>Content</th>
                        <th>Posted</th>
                        <th>Image</th>
                    </tr>
                </thead>
                <tbody>
                    {blogs.map((b) => (
                        <tr key={b.id}>
                            <td>{b.content}</td>
                            <td>{b.postDate}</td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </div>
        </>
    )
}