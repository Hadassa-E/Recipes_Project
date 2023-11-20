import produce from "immer";

const initialState = {
    recipes: [],
    recipe:{}
}

export const recipesReducer = produce((state, action) => {
    switch (action.type) {
        case 'ADD':
            state.recipes = [...state.recipes, action.payload]
            break; 
        case 'SET_LIST_RECIPES':
            state.recipes=action.payload
            break;
        case "SET_RECIPE":
            state.recipe=state.recipes.find(x=>x.RecipeId==action.payload)
            break;
        case 'DELETE':
            let arr=state.recipes
            arr.splice(action.payload,1)
            state.recipes=arr
            break;
        case "UPDATE":
            let a=state.recipes
            a[action.payload.id]=action.payload.recipe
            state.recipes=a
            break;
        default:
            break;
    }
}, initialState)