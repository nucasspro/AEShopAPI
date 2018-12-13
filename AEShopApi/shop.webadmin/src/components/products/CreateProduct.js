import React, { Component } from 'react';
import TextBox from '../TextBox';

export default class CreateProduct extends Component {
  render() {
    return (
      <React.Fragment>
        {/* <div className="card">
          <div className="card-body">
            <h4 className="header-title">Form</h4>
            <TextBox
              htmlFor="example-text-input"
              content="Text"
              type="text"
              placeHolder="nucasspro"
              id="example-text-input"
            />
            <TextBox
              htmlFor="example-search-input"
              content="Search"
              type="search"
              placeHolder="Search .net"
              id="example-search-input"
            />
            <TextBox
              htmlFor="example-email-input"
              content="Email"
              type="search"
              placeHolder="name@example.com"
              id="example-email-input"
            />
            <TextBox
              htmlFor="inputPassword"
              content="Password"
              type="password"
              placeHolder="test123"
              id="inputPassword"
            />

            <div className="form-group">
              <label className="col-form-label">Select</label>
              <select className="form-control">
                <option>Select</option>
                <option>Large select</option>
                <option>Small select</option>
              </select>
            </div>
            <div className="form-group">
              <label className="col-form-label">Custom Select</label>
              <select className="custom-select">
                <option selected="selected">Open this select menu</option>
                <option placeholder="1">One</option>
                <option placeholder="2">Two</option>
                <option placeholder="3">Three</option>
              </select>
            </div>
          </div>
        </div>*/}
        <form action="#">
          <b className="text-muted mb-3 d-block">Checkbox:</b>
          <div className="custom-control custom-checkbox">
            <input
              type="checkbox"
              checked=""
              className="custom-control-input"
              id="customCheck1"
            />
            <label className="custom-control-label" for="customCheck1">
              checked Checkbox
            </label>
          </div>
          <div className="custom-control custom-checkbox">
            <input
              type="checkbox"
              className="custom-control-input"
              id="customCheck2"
            />
            <label className="custom-control-label" for="customCheck2">
              Unchecked Checkbox
            </label>
          </div>
          <div className="mb-3" />
          <div className="custom-control custom-checkbox">
            <input
              type="checkbox"
              checked=""
              disabled=""
              className="custom-control-input"
              id="customCheck3"
            />
            <label className="custom-control-label" for="customCheck3">
              checked Checkbox
            </label>
          </div>
          <div className="custom-control custom-checkbox">
            <input
              type="checkbox"
              disabled=""
              className="custom-control-input"
              id="customCheck4"
            />
            <label className="custom-control-label" for="customCheck4">
              Unchecked Checkbox
            </label>
          </div>
          <b className="text-muted mb-3 mt-4 d-block">Inline Checkbox:</b>
          <div className="custom-control custom-checkbox custom-control-inline">
            <input
              type="checkbox"
              checked=""
              className="custom-control-input"
              id="customCheck5"
            />
            <label className="custom-control-label" for="customCheck5">
              checked Checkbox
            </label>
          </div>
          <div className="custom-control custom-checkbox custom-control-inline">
            <input
              type="checkbox"
              className="custom-control-input"
              id="customCheck6"
            />
            <label className="custom-control-label" for="customCheck6">
              Unchecked Checkbox
            </label>
          </div>
          <div className="mb-3" />
          <div className="custom-control custom-checkbox custom-control-inline">
            <input
              type="checkbox"
              checked=""
              disabled=""
              className="custom-control-input"
              id="customCheck7"
            />
            <label className="custom-control-label" for="customCheck7">
              checked Checkbox
            </label>
          </div>
          <div className="custom-control custom-checkbox custom-control-inline">
            <input
              type="checkbox"
              disabled=""
              className="custom-control-input"
              id="customCheck8"
            />
            <label className="custom-control-label" for="customCheck8">
              Unchecked Checkbox
            </label>
          </div>
        </form>
      </React.Fragment>
    );
  }
}
