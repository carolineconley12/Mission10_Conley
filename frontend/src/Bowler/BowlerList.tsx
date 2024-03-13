import { useEffect, useState } from 'react';
import { BowlerTeamInfo } from '../types/BowlerTeamInfo';
function BowlerList() {
  const [BowlerData, setBowlerData] = useState<BowlerTeamInfo[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('https://localhost:7053/Bowler');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">=</div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {BowlerData.map((b) => (
            <tr>
              <td>{b.bowlerFullName}</td>
              <td>{b.teamName}</td>
              <td>{b.address}</td>
              <td>{b.city}</td>
              <td>{b.state}</td>
              <td>{b.zip}</td>
              <td>{b.phoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
