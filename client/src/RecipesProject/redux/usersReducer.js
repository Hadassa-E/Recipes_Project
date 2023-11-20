import produce from "immer";

const initialState = {
    currentUser: {UserId:0, FirstName: "אורח",LastName:"" },
    users: [],
    user:{}
}

export const usersReducer = produce((state, action) => {
    switch (action.type) {
        case 'SET_CURRENT_USER':
            state.currentUser = action.payload
            break; 
        case 'SET_LIST_USERS':
            state.users = action.payload
            break; 
        case 'ADD':
            state.users = [...state.users, action.payload]
            break;
        default:
            break;
    }
}, initialState)