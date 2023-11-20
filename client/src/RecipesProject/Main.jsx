import { HomePage } from "./HomePage"
import { Provider } from 'react-redux';
import store from './redux/Store';
import { Routing } from "./Routing";
import { BrowserRouter } from "react-router-dom";
import { useEffect } from "react";
import { useNavigate } from "react-router"
import { Nav } from "./Nav";

export const Main = () => {

    return <>

        <Provider store={store}>
            <BrowserRouter>
                <Nav></Nav>
                <Routing></Routing>
            </BrowserRouter>
        </Provider>



    </>
}