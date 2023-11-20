import axios from "axios"

export const GetAllAPI = () => {
    return axios.get(`https://localhost:7030/api/Recipe/GetAll`)
}
export const GetByIdAPI = (id) => {
    return axios.get(`https://localhost:7030/api/Recipe/GetById/${id}`)
}
export const AddAPI = (user) => {
    return axios.post(`https://localhost:7030/api/Recipe/Add`,user)
}
export const DeleteAPI = (id) => {
    return axios.delete(`https://localhost:7030/api/Recipe/Delete`,id)
}
export const UpdateAPI = (id,recipe) => {
    return axios.patch(`https://localhost:7030/api/Recipe/Update/${id}`,recipe)
}


