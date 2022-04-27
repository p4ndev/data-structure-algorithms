import React from 'react'
import { MainHeader, SubHeader, Submit, Switchable } from '../dumb'

export const Register = () => {

  return (
    <main>

      <MainHeader prefix="Please, fill " strong="you email" suffix="." />

      <div className="row mb-4">
        <div className="col-12">  
          <input type="email" placeholder="E-mail *" style={{ width: "100%" }} />
        </div>
      </div>

      <SubHeader prefix="What are you " strong="up to" suffix="?" />

      <div className="row">
        <div className="col-6">
          <Switchable title="I'm arriving" cssClass="" />
        </div>
        <div className="col-6">
          <Switchable title="I'm leaving" cssClass="" />
        </div>
      </div>

      <Submit title="Send" />

    </main>
  )

}