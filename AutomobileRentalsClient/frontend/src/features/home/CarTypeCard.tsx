import { CarType } from "../../app/models/CarType";

interface Props {
  carType: CarType;
}

//to be improved button needed

export default function CarTypeCard({ carType }: Props) {
  return (
    <>
      <div className="card">
        <img src={carType.imageUrl} className="card-img-top" alt="..." />
        <div className="card-body">
          <h5 className="card-title">{carType.name}</h5>
          <p className="card-text">{carType.description}</p>
        </div>
      </div>
    </>
  );
}
