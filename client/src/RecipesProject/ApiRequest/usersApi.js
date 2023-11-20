import axios from "axios"

export const GetAllAPI = () => {
    return axios.get(`https://localhost:7030/api/User/GetAll`)
}
export const GetByIdAPI = (id) => {
    return axios.get(`https://localhost:7030/api/User/GetById/${id}`)
}
export const GetByMailAndPasswordAPI = (mail,password) => {
    return axios.get(`https://localhost:7030/api/User/GetByMailAndPassword/${mail}/${password}`)
}
export const AddAPI = (user) => {
    return axios.post(`https://localhost:7030/api/User/Add`,user)
}

