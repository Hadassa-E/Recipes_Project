export const setCurrentUser = (user) => {
    return { type: 'SET_CURRENT_USER', payload: user }
}
export const setListUsers = (users) => {
    return { type: 'SET_LIST_USERS', payload: users }
}
export const Add = (user) => {
    return { type: 'ADD', payload: user }
}

