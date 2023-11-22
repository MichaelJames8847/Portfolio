const apiUrl = "/api/blog";

export const getBlogs = () => {
    return fetch(apiUrl).then((res) => res.json());
};

export const getBlogById = (id) => {
    return fetch(`${apiUrl}/${id}`).then((res) => res.json());
};

export const createBlog = (blogData) => {
    return fetch(`${apiUrl}/create`, {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
            "Authorization": `Bearer ${process.env.REACT_APP_AUTH_TOKEN}`
        },
        body: JSON.stringify(blogData)
    });
};