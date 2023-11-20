import { useRef, useState, useEffect } from "react"
import { useNavigate } from "react-router-dom"
import swal from "sweetalert"
import {GetByMailAndPasswordAPI} from "./ApiRequest/usersApi"
import { setCurrentUser } from "./redux/usersAction";
import { useDispatch } from 'react-redux';
import {SignUp} from "./SignUp"
import "./styles/Forms.css"

export const LogIn = () => {
    const mailU = useRef()
    const passU = useRef()
    let nav = useNavigate()
    const dispatch = useDispatch()
    const [showSignUp, setShowSignUp] = useState(false)
    const check = () => {
        GetByMailAndPasswordAPI(mailU.current.value,passU.current.value)
                    .then(x => {
                        if(x.data!=""){
                            dispatch(setCurrentUser(x.data))
                            swal("התחברות", "שלום "+x.data.FirstName+" הינך קיים במערכת!", "success")
                            nav("/HomePage")
                    }
                    else{
                        swal("התחברות", "אינך קיים במערכת. הינך מועבר להרשמה", "error")
                        setShowSignUp(true)
                    }
                    })
                    .catch(err => {
                        console.log(err.message);
                    })
    }
    return <>
        {!showSignUp && <div className="frm"><h1>התחברות</h1>
            <input placeholder={'מייל'} className="inp" value={"hadassa@gmail.com"} ref={mailU}></input><br></br>
            <input placeholder={'סיסמה'} className="inp" value={"Hadas2900"} ref={passU}></input><br></br>
            {/* <button onClick={() => check()}>התחברות</button><br></br> */}
<button className="button-55" onClick={() => check()}> להתחברות לחץ</button>
            <br></br></div>}
        {showSignUp && <SignUp></SignUp>}
    </>
}