import {useRef, useState, useEffect } from "react"
import { AddAPI } from "./ApiRequest/ingApi"
import swal from "sweetalert"
import { useDispatch } from 'react-redux';
import { Add } from "./redux/ingsAction";
import "./styles/Forms.css"


export const AddIng = (props) => {
    const [addIng, setAddIng] = useState(props.addIng)
    const [ing, setIng] = useState([])
    const ingName = useRef()
    const Send = () => {
        
        setAddIng(false)
        setIng({
            IngName: ingName.current.value
        })
        AddAPI(ing)
            .then(x => {
                swal("הוספת מוצר חדש", "המוצר נוסף בהצלחה!!!", "success")
                setIng({ IngName: ing.IngName })
                update()
            })
            .catch(err => {
                alert(err.message);
            })
    }
    const dispatch = useDispatch()
    const update = () => {
        debugger
        dispatch(Add(ing))
    }

    return <>
        {<div><h2>הוספת רכיב</h2>
            <input type={"text"} className="inp" placeholder="שם הרכיב" ref={ingName} required/><br></br>
            <input type="button" className="button-13" value={"אישור"} onClick={()=>Send()}/></div>}
    </>
}
