import React, { Component } from 'react';
import Navbar from './Nav';
import Header from './Header';
import PageTitle from './PageTitle';

export default class Layout extends Component {
  render() {
    return (
      <React.Fragment>
        <div className="page-container">
          <div className="sidebar-menu">
            <Navbar />
          </div>
          <div className="main-content">
            <div className="header-area">
              <Header />
            </div>
            <div className="page-title-area">
              <PageTitle />
            </div>
            <div className="main-content-inner">
              <div className="row">
                <div className="col-12 mt-5">
                  {this.props.children}
                </div>
              </div>
            </div>
          </div>
          <div className="footer">
            <p>Footer</p>
          </div>
        </div>
      </React.Fragment>
    );
  }
}
