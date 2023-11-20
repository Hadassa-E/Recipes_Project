import { Route, Routes } from "react-router-dom"
import { LogIn } from "./LogIn"
import { HomePage } from "./HomePage"
import { SignUp } from "./SignUp"
import { ShowOneRecipe } from "./ShowOneRecipe"
import { AddRecipes } from "./AddRecipes"


export const Routing = () => {
    return <>
        <Routes>
            <Route path={'/'} element={<HomePage></HomePage>}></Route>
            <Route path={'HomePage'} element={<HomePage></HomePage>}></Route>
            <Route path={'LogIn'} element={<LogIn></LogIn>}></Route>
            <Route path={'SignUp'} element={<SignUp></SignUp>}></Route>
            <Route path={'ShowOneRecipe/:id'} element={<ShowOneRecipe></ShowOneRecipe>}></Route>
            <Route path={'HomePage/ShowOneRecipe/:id'} element={<ShowOneRecipe></ShowOneRecipe>}></Route>
            <Route path={'AddRecipes'} element={<AddRecipes></AddRecipes>}></Route>
        </Routes>
    </>
}