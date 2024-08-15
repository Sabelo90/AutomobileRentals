import { Carousel } from "react-bootstrap";

export default function HomeCorousel() {
  return (
    <>
      <div>
        <Carousel
          data-bs-theme="dark"
          controls={false}
          indicators={false}
          fade={true}
          className="corr"
          pause={"hover"}
        >
          <Carousel.Item interval={3000}>
            <img
              className="d-block w-100"
              src="./public/Banner(1).jpg"
              alt="First slide"
            />
            <Carousel.Caption>
              <h5>First slide label</h5>
              <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
            </Carousel.Caption>
          </Carousel.Item>
          <Carousel.Item interval={3000}>
            <img
              className="d-block w-100"
              src="./public/Banner(2).jpg"
              alt="First slide"
            />
            <Carousel.Caption>
              <h5>First slide label</h5>
              <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
            </Carousel.Caption>
          </Carousel.Item>
          <Carousel.Item interval={3000}>
            <img
              className="d-block w-100"
              src="./public/Banner(3).jpg"
              alt="First slide"
            />
            <Carousel.Caption>
              <h5>First slide label</h5>
              <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
            </Carousel.Caption>
          </Carousel.Item>
        </Carousel>
      </div>
    </>
  );
}
