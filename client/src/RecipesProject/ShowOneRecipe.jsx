import { useEffect, useState } from "react"
import { useParams } from "react-router"
import { useSelector } from "react-redux"
import { GetByRecipeIdAPI } from "./ApiRequest/ingToRecipesApi"
import { GetByIdAPI } from "./ApiRequest/usersApi"
import "./styles/ShowOneRecipes.css"
export const ShowOneRecipe = () => {
    const recipe = useSelector(r => r.recipes.recipe)
    const ings = useSelector(i => i.ings.ings)
    let params = useParams()
    const [ing, setIng] = useState([])
    let [name, setName] = useState("")
    useEffect(() => {
        GetByRecipeIdAPI(params.id - "0")
            .then(x => {
                debugger
                setIng(x.data)
                console.log(ing)
                console.log(x.data)
            })
            .catch(err => {
                console.log(err.message);
            })

        GetByIdAPI(recipe.UserId)
            .then(x => {
                setName(x.data.FirstName + " " + x.data.LastName)
            })
            .catch(err => {
                console.log(err.message);
            })
    }, [])
    return <>
        <section className="ShowOneRecipe">
            <div className="Preparation"> <h1 className="RecipeName">שם המתכון: {recipe.RecipeName}</h1>
                <h3 className="LevelAndTime">רמה: {recipe.Level}  |  זמן הכנה: {recipe.Time} דקות</h3>
                <h2>הרכיבים:</h2>
                <ul>
                    {ing.map(i => <li>{i.Quantity} גרם {ings.filter(j => j.IngId == i.IngId)[0].IngName}</li>)}
                </ul>
                {name != "" && <h3>©הועלה על ידי {name}</h3>}</div>
            <img className="ShowPicToOneRecipe" src={`${process.env.PUBLIC_URL}/images/${recipe.Pic}`}></img>
</section>



    </>
}