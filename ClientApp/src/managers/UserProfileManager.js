const apiUrl = "/api/userprofile";

export const getUserProfile = () => {
    return fetch(apiUrl).then((res) => res.json());
};