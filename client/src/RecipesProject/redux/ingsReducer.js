import produce from "immer";

const initialState = {
    ings: [],
    ing:{}
}

export const ingsReducer = produce((state, action) => {
    switch (action.type) {
        case 'ADD':
            state.ings = [...state.ings, action.payload]
            break; 
        case 'SET_LIST_INGS':
            state.ings=action.payload
            break;
        case "SET_ING":
            state.ing=action.payload
            break;
        default:
            break;
    }
}, initialState)