export const setListRecipes = (recipes) => {
    return { type: 'SET_LIST_RECIPES', payload: recipes }
}
export const setRecipe = (id) => {
    return { type: 'SET_RECIPE', payload: id }
}
export const Add = (recipe) => {
    return { type: 'ADD', payload: recipe }
}

export const Delete = (id) => {
    return { type: 'DELETE', payload: id }
}

export const Update = (id,recipe) => {
    return { type: 'UPDATE', payload: {id,recipe} }
}