export const setListIngs = (ings) => {
    return { type: 'SET_LIST_INGS', payload: ings }
}
export const setIng = (id) => {
    return { type: 'SET_ING', payload: id }
}
export const Add = (ing) => {
    return { type: 'ADD', payload: ing }
}

