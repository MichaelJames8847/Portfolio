const apiUrl = "/api/blog";

export const getBlogs = () => {
    return fetch(apiUrl).then((res) => res.json());
};

export const getBlogById = (id) => {
    return fetch(`${apiUrl}/${id}`).then((res) => res.json());
};