import React, { Component } from 'react';

/*
    [Component      => Type]
    Username, Text  => text
    Password        => password 
    Time            => time
    Date            => date
    DateAndTime	    => datetime-local
    Number	        => number
    Month           => month
    Week            => week
    Email           => email
*/

export default class TextBox extends Component {
  render() {
    const { htmlFor, content, placeHolder, type, id } = this.props;
    return (
      <React.Fragment>
        <div className="form-group">
          <label htmlFor={htmlFor} className="col-form-label">
            {content}
          </label>
          <input
            className="form-control"
            type={type}
            placeholder={placeHolder}
            id={id}
          />
        </div>
      </React.Fragment>
    );
  }
}
