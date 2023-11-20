import { NavLink } from "react-router-dom"
import "./styles/Nav.css"
import { useSelector } from "react-redux"
import LogoPic from '../assets/Brown and Pink Cute Cupcake Bakery Logo.gif'


export const Nav=()=>{
    const u = useSelector(u => u.users.currentUser)

    return<>
    <div className={'nav'}>
    <img className="logo" src={LogoPic}></img>
    <NavLink to={'HomePage'} className={'link'}>דף הבית</NavLink>
    {u.UserId==0&&<NavLink to={'LogIn'} className={'link'}>התחברות</NavLink>}
    {u.UserId==0&&<NavLink to={'SignUp'} className={'link'}>הרשמה</NavLink>}
        {u.UserId!=0&&<NavLink to={'AddRecipes'} className={'link'}>הוספת מתכון</NavLink>}
        <p>שלום {u.FirstName} {u.LastName}</p>
    </div>
    </>
}