import axios from "axios"

export const GetAllIngAPI = () => {
    return axios.get(`https://localhost:7030/api/Ing/GetAll`)
}
export const GetByIdAPI = (id) => {
    return axios.get(`https://localhost:7030/api/Ing/GetById/${id}`)
}
export const AddAPI = (ing) => {
    debugger
    return axios.post(`https://localhost:7030/api/Ing/Add`,ing)
}