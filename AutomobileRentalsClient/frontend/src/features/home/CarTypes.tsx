import { useEffect, useState } from "react";
import { CarType } from "../../app/models/CarType";
import CarTypeCard from "./CarTypeCard";

export default function CarTypes() {
  const [cartypes, addCarType] = useState<CarType[]>([]);


  //ToBeRemoved
  function InsertCarType() {
    addCarType([
      ...cartypes,
      {
        id: 1,
        name: "Sedan",
        description:
          "Small to medium sized car with seating for four or more passengers.",
        imageUrl: "https://example.com/images/sedan.jpg",
      },
    ]);
  }

  useEffect(() => {
    fetch("https://localhost:7134/api/CarType/GetAll")
      .then((response) => response.json())
      .then((data) => addCarType(data));
  });

  return (
    <>
      <div className="container mt-5">
        <div className=" row ">
          {cartypes.map((carType) => (
            <div key={carType.id} className="col-md-3">
             <CarTypeCard carType={carType} />
            </div>
          ))}
        </div>
      </div>
    </>
  );
}
