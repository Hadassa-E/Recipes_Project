import axios from "axios"

export const GetAllAPI = () => {
    return axios.get(`https://localhost:7030/api/IngToRecipe/GetAll`)
}
export const GetByRecipeIdAPI = (id) => {
    return axios.get(`https://localhost:7030/api/IngToRecipe/GetByRecipeId/${id}`)
}
export const AddIngToRecipeAPI = (id,ing) => {
    return axios.post(`https://localhost:7030/api/IngToRecipe/Add/${id}`,ing)
}