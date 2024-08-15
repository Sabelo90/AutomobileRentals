import { Navigate, createBrowserRouter } from "react-router-dom";

import Book from "../../features/book/book";
import Test from "../../features/test-drive/test";
import Support from "../../features/support/support";
import Login from "../../features/account/login/login";
import Register from "../../features/account/register/register";
import App from "../../App";
import Home from "../../features/home/home";

const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      { index: true, element: <Navigate to="/home" replace /> },
      { path: "/home", element: <Home /> },
      { path: "/book", element: <Book /> },
      { path: "/test-drive", element: <Test /> },
      { path: "/support", element: <Support /> },
      { path: "/login", element: <Login /> },
      { path: "/register", element: <Register /> },
    ],
  },
]);

export const routes = router;
