import React          from 'react';
import { MainHeader } from '../dumb';

export const Report = () => {

  return (
    <main>

      <MainHeader prefix="Here's my " strong="activities" suffix="." />

      <table>
          <thead>
            <tr>
              <th style={{ width: "40%" }}>Email</th>
              <th style={{ width: "40%" }}>Period</th>
              <th style={{ width: "20%", textAlign: "center" }}>Action</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>email1@uol.com.br</td>
              <td>01/02/2022 10:10 AM</td>
              <td className="text-center">
                <strong role="icon">«</strong> Arriving
              </td>
            </tr>
            <tr>
              <td>email1@uol.com.br</td>
              <td>01/02/2022 10:10 AM</td>
              <td className="text-center">
                Leaving <strong role="icon">»</strong>
              </td>
            </tr>
          </tbody>
      </table>

      <p style={{ textAlign: "right", fontSize: "0.9em", paddingTop: "5px", opacity: 0.3 }}>
        ...from <em>worldcellos@gmail.com</em>
      </p>

    </main>
  );

}