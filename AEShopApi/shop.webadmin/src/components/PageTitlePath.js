import React, { Component } from 'react';

export default class PageTitlePath extends Component {
  render() {
    const { navButtonName, href, current } = this.props;
    return (
      <React.Fragment>
        <h4 className="page-title pull-left">{navButtonName}</h4>
        <ul className="breadcrumbs pull-left">
          <li>
            <a href="index.html">{href}</a>
          </li>
          <li>
            <span>{current}</span>
          </li>
        </ul>
      </React.Fragment>
    );
  }
}
