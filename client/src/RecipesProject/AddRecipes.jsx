import { useState, useRef } from "react"
import { AddAPI } from "./ApiRequest/recipesApi"
import swal from "sweetalert"
import { useDispatch, useSelector } from 'react-redux';
import { Add } from "./redux/recipesAction";
import Multiselect from "multiselect-react-dropdown";
import { AddIngToRecipeAPI } from "./ApiRequest/ingToRecipesApi";
import { AddIng } from "./AddIng"
import "./styles/Forms.css"


export const AddRecipes = () => {
    const ings = useSelector(i => i.ings.ings)
    const [addIng, setAddIng] = useState(false)
    const [chooseAmounts, SetChooseAmounts] = useState(false)
    const RecipeNameRef = useRef()
    const RecipePicRef = useRef()
    const RecipeLevelRef = useRef()
    const RecipeTimeRef = useRef()
    const state = {
        options: []
    };
    for (let i = 0; i < ings.length; i++) {
        (state.options).push({ name: ings[i].IngName, id: ings[i].IngId })
    }
    console.log(ings, "ings")
    console.log(state.options, "state.options");

    console.log(state.options)
    const cu = useSelector(u => u.users.currentUser)
    const [recipe, setRecipe] = useState([])
    const [ingToRecipe, setIngToRecipe] = useState([])//עבור שליחה לשרת
    const [listIngs, setListIngs] = useState([])//הרכיבים שנבחרו

    const UpdateRecipe = () => {
        debugger
        SetChooseAmounts(true)
        setRecipe({
            RecipeName: RecipeNameRef.current.value,
            Pic: RecipePicRef.current.value.substring(12),
            Level: RecipeLevelRef.current.value,
            Time: RecipeTimeRef.current.value,
            UserId: cu.UserId
        })
    }
    const Send = () => {
        AddAPI(recipe)
            .then(x => {
                setRecipe(
                    { RecipeName: recipe.RecipeName },
                    { Pic: recipe.Pic },
                    { Level: recipe.Level },
                    { Time: recipe.Time },
                    { UserId: recipe.UserId })
                    swal("הוספת מתכון חדש", "המתכון נוסף בהצלחה!!!", "success")

                update()
                for (let index = 0; index < listIngs.length; index++) {
                    debugger
                    let OneIng={
                        RecipeId: x.data.RecipeId,
                        IngId: listIngs[index].id,
                        Quantity: document.getElementById((listIngs[index].id).toString()).value - "0"
                    }
                    debugger
                    let arr=ingToRecipe
                    arr.push(OneIng)
                    console.log(arr);
                    debugger
                    setIngToRecipe(arr)
                    debugger
                }
                AddIngToRecipeAPI(x.data.RecipeId, ingToRecipe)
                    .then(x => {
                        swal("הוספת מתכון חדש", "המתכון נוסף בהצלחה!!!", "success")
                        debugger
                        // setIngToRecipe(
                        //     { RecipeId: recipe.RecipeName },
                        //     { IngId: recipe.Pic },
                        //     { Quantity: recipe.Level })
                    })
                    .catch(err => {
                        alert(err.message);
                    })

            })
            .catch(err => {
                alert(err.message);
            })
    }
    const dispatch = useDispatch()
    const update = () => {
        dispatch(Add(recipe))
    }
    const MoreOrLess = (selectedList) => {
        setListIngs(selectedList)
        console.log(selectedList);
    }
    return <>
        <section className="frm">
            <h1>הוספת מתכון</h1>
            {!chooseAmounts &&
                <div>
                    <input type={"text"} className="inp" placeholder="שם המתכון" required ref={RecipeNameRef} /><br></br>
                    <label>תמונה</label><br></br><input type={"file"} className="inp" required ref={RecipePicRef} /><br></br>
                    <label>רמת קושי</label><br></br>
                    <select ref={RecipeLevelRef} className="inp">
                        <option>קל</option>
                        <option>בינוני</option>
                        <option>קשה</option>
                    </select>
                    <input type={"number"} className="inp" placeholder="זמן הכנה בדקות" required ref={RecipeTimeRef} /><br></br>
                    <br></br>
                    <label>בחר רכיבים למתכון לסיום הקש על שמירה,<br></br>להוספת רכיב שלא קיים לחץ על הוספת רכיב חדש</label>
                    <Multiselect
                        options={state.options}
                        selectedValues={state.selectedValue}
                        onSelect={MoreOrLess}
                        onRemove={MoreOrLess}
                        displayValue="name">
                    </Multiselect>

                    {!addIng && <button className="button-13" value={"הוספת רכיב חדש"} onClick={() => setAddIng(true)}>הוספת רכיב חדש</button>}
                    <br></br>
                    {addIng && <AddIng addIng={addIng}></AddIng>}
                    <button className="button-55" onClick={() => UpdateRecipe()}>שמירה</button>
                </div>}
            {chooseAmounts && <div>
                <h4>הכנס כמויות למוצרים שבחרת:</h4>
                {listIngs.map(x =>
                    <div className="chooseAmounts">
                        <label>{x.name}</label>
                        <input type="number" className="amount" id={x.id}></input>
                        <label>גרם</label>
                        <br></br>

                    </div>

                )}
                <button className="button-55" onClick={() => Send()}>הוספת מתכון</button>
            </div>}
        </section>
    </>
}

