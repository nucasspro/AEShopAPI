import React, { Component } from 'react';
import avatar from '../images/author/avatar.png';
import PageTitlePath from './PageTitlePath';

export default class PageTitle extends Component {
  render() {
    return (
      <React.Fragment>
        <div className="row align-items-center">
          <div className="col-sm-6">
            <div className="breadcrumbs-area clearfix">
              <PageTitlePath
                navButtonName="Dashboard"
                href="Home"
                current="Database"
              />
            </div>
          </div>
          <div className="col-sm-6 clearfix">
            <div className="user-profile pull-right">
              <img className="avatar user-thumb" src={avatar} alt="avatar" />
              <h4 className="user-name dropdown-toggle" data-toggle="dropdown">
                Kumkum Rai <i className="fa fa-angle-down" />
              </h4>
              <div className="dropdown-menu">
                <a className="dropdown-item" href="/">
                  Message
                </a>
                <a className="dropdown-item" href="/">
                  Settings
                </a>
                <a className="dropdown-item" href="/">
                  Log Out
                </a>
              </div>
            </div>
          </div>
        </div>
      </React.Fragment>
    );
  }
}
