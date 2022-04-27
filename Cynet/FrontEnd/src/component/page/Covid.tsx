import React            from 'react'
import { MainHeader, SubHeader, Submit }   from '../dumb';

export const Covid = () => {

  return (
    <main>

      <div className="row pt-0 mt-0">
        <div className="col-8 pt-0 mt-0">
          <MainHeader prefix="When had you " strong="diagnosed" suffix="?" />
        </div>
        <div className="col-2 pt-2">
          <input type="date" style={{ width: "100%" }} />
        </div>
        <div className="col-2 pt-2">
          <input type="time" style={{ width: "100%" }} />
        </div>
      </div>

      <hr className="mb-4" />

      <SubHeader prefix="Who do you want to " strong="notify" suffix="?" />

      <table className="mt-3 mb-3">
        <thead>
          <tr>
            <th style={{ width: "10%", textAlign: "center" }}>#</th>
            <th style={{ width: "90%" }}>Email</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td className="text-center"><input type="checkbox" /></td>
            <td>email1@uol.com.br</td>
          </tr>
          <tr>
            <td className="text-center"><input type="checkbox" /></td>
            <td>email1@uol.com.br</td>
          </tr>
        </tbody>
      </table>

      <Submit title="Send" />

    </main>
  );

}