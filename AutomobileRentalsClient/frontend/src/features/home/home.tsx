import { Container } from "react-bootstrap";
import HomeCorousel from "./homeCorousel";
import CarTypes from "./CarTypes";

export default function Home() {
  return (
    <>
      <HomeCorousel />
      <Container>
        <h1>Welcome to Automobile Rentals</h1>
      </Container>
      <CarTypes />
    </>
  );
}
