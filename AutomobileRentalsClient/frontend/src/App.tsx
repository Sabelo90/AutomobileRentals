import "./App.css";
import "bootstrap/dist/css/bootstrap.min.css";
import { Outlet, useLocation } from "react-router-dom";
import Header from "./app/header/app_header";
import { Container } from "react-bootstrap";

function App() {
  const location = useLocation().pathname;
  return (
    <>
      <Header />
      {location.includes("home") ? (
        <Outlet />
      ) : (
        <Container>
          <Outlet />
        </Container>
      )}
    </>
  );
}

export default App;
