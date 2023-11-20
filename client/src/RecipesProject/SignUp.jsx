import { useState } from "react"
import { useNavigate } from "react-router-dom"
import { AddAPI } from "./ApiRequest/usersApi"
import swal from "sweetalert"
import { setCurrentUser } from "./redux/usersAction";
import { useDispatch } from 'react-redux';
import "./styles/Forms.css"


export const SignUp=()=>{
    const [user,setUser] = useState([])
    let nav = useNavigate()
    const Send = (event) => {
        event.preventDefault();
        setUser( {
            FirstName: event.target[0].value,
            LastName: event.target[1].value,
            Email: event.target[2].value,
            Password: event.target[3].value,
        })
        AddAPI(user)
                .then(x => {
                    if(x!=-1){
                    swal("הוספת לקוח חדש","הלקוח "+user.FirstName+" "+user.LastName+" נוסף בהצלחה!!!","success")
                    setUser( 
                        {UserId: x},
                        {FirstName:user.FirstName},
                       { LastName: user.LastName},
                       { Email: user.Email},
                        {Password: user.Password})
                    update()
                    nav("/HomePage")
                    }
                    else
                    alert("כנראה שהנתונים שהזנת לא עוברים את בדיקות התקינות בשרת")
                })
                .catch(err => {
                    alert(err.message);
                })
        console.log(user)
    }
    const dispatch = useDispatch()
    const update=()=>{  
    dispatch(setCurrentUser(user))
}
    return <>
        <form onSubmit={(e) => Send(e)} className="frm">
        <h1>הרשמה</h1>
            <input type={"text"} className="inp" placeholder="שם פרטי" required /><br></br>
            <input type={"text"} className="inp" placeholder="שם משפחה" required /><br></br>
            <input type={"mail"} className="inp" placeholder="מייל" required /><br></br>
            <input type={"password"} className="inp" placeholder="סיסמה" required /><br></br>
            <br/><input type="submit" className="button-55" value={"להרשמה לחץ"}/>
        </form>
    </>
}
