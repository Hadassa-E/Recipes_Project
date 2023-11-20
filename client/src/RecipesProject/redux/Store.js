import { createStore, combineReducers } from "redux";
import { recipesReducer } from './recipesReducer'
import { usersReducer } from './usersReducer'
import { ingsReducer } from './ingsReducer'


const reducer = combineReducers({
    recipes: recipesReducer,
    users: usersReducer,
    ings: ingsReducer
})

const store = createStore(reducer)
window.store = store
export default store;