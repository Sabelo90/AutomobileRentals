import { Nav } from "react-bootstrap";
import { FaCarAlt, FaHome } from "react-icons/fa";
import { FaRoad } from "react-icons/fa6";
import { MdCall } from "react-icons/md";
import { NavLink, useLocation } from "react-router-dom";

export default function Header() {
  const location = useLocation().pathname;
  return (
    <>
      <header>
        <div className="px-3 py-2 bg-dark text-white">
          <div className="container">
            <div className="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
              <a
                href="/"
                style={{ fontWeight: "bolder", fontSize: "1.3em" }}
                className="d-flex align-items-center my-2 my-lg-0 me-lg-auto text-white text-decoration-none"
              >
                AUTOMOBILE
                <span
                  style={{
                    display: "inline-block",
                    color: "darkgoldenrod",
                  }}
                >
                  RENTALS
                </span>
              </a>

              <ul className="nav col-12 col-lg-auto my-2 justify-content-center my-md-0 text-small">
                <li>
                  <Nav.Link
                    as={NavLink}
                    to={"/home"}
                    className={`nav-link ${
                      location.includes("home") ? "text-warning" : "text-white"
                    }`}
                  >
                    <FaHome
                      size={"1.3em"}
                      className="bi d-block mx-auto mb-1"
                    />
                    Home
                  </Nav.Link>
                </li>
                <li>
                  <Nav.Link
                    as={NavLink}
                    to={"/book"}
                    className={`nav-link ${
                      location.includes("book") ? "text-warning" : "text-white"
                    }`}
                  >
                    <FaCarAlt
                      size={"1.3em"}
                      className="bi d-block mx-auto mb-1"
                    />
                    Book A Vehicle
                  </Nav.Link>
                </li>
                <li>
                  <Nav.Link
                    as={NavLink}
                    to={"/test-drive"}
                    className={`nav-link ${
                      location.includes("test") ? "text-warning" : "text-white"
                    }`}
                  >
                    <FaRoad
                      size={"1.3em"}
                      className="bi d-block mx-auto mb-1"
                    />
                    Test drive
                  </Nav.Link>
                </li>
                <li>
                  <Nav.Link
                    as={NavLink}
                    to={"/support"}
                    className={`nav-link ${
                      location.includes("support")
                        ? "text-warning"
                        : "text-white"
                    }`}
                  >
                    <MdCall
                      size={"1.3em"}
                      className="bi d-block mx-auto mb-1"
                    />
                    Support
                  </Nav.Link>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <div className="px-3 py-2 border-bottom">
          <div className="container d-flex flex-wrap justify-content-center">
            <form className="col-12 col-lg-auto mb-2 mb-lg-0 me-lg-auto">
              <input
                type="search"
                className="form-control"
                placeholder="Search..."
                aria-label="Search"
              />
            </form>

            <div className="text-end">
              <Nav.Item
                as={NavLink}
                to={"/login"}
                type="button"
                className="btn btn-light text-dark me-2"
              >
                Login
              </Nav.Item>
              <Nav.Item
                as={NavLink}
                to={"/register"}
                type="button"
                className="btn btn-warning"
              >
                Sign-up
              </Nav.Item>
            </div>
          </div>
        </div>
      </header>
    </>
  );
}
