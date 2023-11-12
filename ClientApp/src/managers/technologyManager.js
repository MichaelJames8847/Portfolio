const apiUrl = "/api/technology"

export const getTechnologies = () => {
    return fetch(apiUrl).then((res) => res.json());
};

export const getTechnologyById = (id) => {
    return fetch(`${apiUrl}/${id}`).then((res) => res.json());
};