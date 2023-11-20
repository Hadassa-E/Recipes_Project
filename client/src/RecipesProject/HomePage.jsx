import { GetAllAPI } from "./ApiRequest/recipesApi"
import { useState, useEffect } from "react"
import "./styles/HomePage.css"
import { Route, Router } from "react-router-dom"
import {ShowOneRecipe} from "./ShowOneRecipe"
import { useNavigate } from "react-router"
import { useSelector } from "react-redux"
import { useDispatch } from 'react-redux';
import {setRecipe, setListRecipes } from "./redux/recipesAction";
import {GetAllIngAPI} from "./ApiRequest/ingApi"
import {setListIngs} from "./redux/ingsAction"



export const HomePage = () => {
    const dispatch = useDispatch()
   const list=useSelector(x=>x.recipes.recipes)
    const [allRecipes, setAllRecipes] = useState(list)
    useEffect(() => {
        GetAllAPI()
            .then(x => {
                setAllRecipes(x.data)
                dispatch(setListRecipes(x.data))
            })
            .catch(err => {
                console.log(err.message);
            })
            GetAllIngAPI()
            .then(x => {
                console.log(x.data)
                dispatch(setListIngs(x.data))
            })
            .catch(err => {
                console.log(err.message);
            })
    }, [])
    const navigate = useNavigate()
   const Navigate=(id)=>{
    debugger
    dispatch(setRecipe(id))
        navigate(`ShowOneRecipe/${id}`)
    }
    return <>
    <section className="container">
     {allRecipes.map(i => 
    <figure className="OneRecipe" onClick={()=>Navigate(i.RecipeId)}>
    <img className="ImgOneRecipe" src={`${process.env.PUBLIC_URL}/images/${i.Pic}`}></img>
    <h1 className="RecipeName">{i.RecipeName}</h1>
    <figcaption>רמת קושי: {i.Level}</figcaption>
    </figure>)}
       </section>
    </>
}