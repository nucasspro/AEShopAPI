import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export default class Nav extends Component {
  render() {
    return (
      <React.Fragment>
        <div className="sidebar-header">
          <div className="logo">
            <a href="index.html">NU Shop Admin</a>
          </div>
        </div>
        <div className="main-menu">
          <div className="slimScrollDiv">
            <div className="menu-inner">
              <nav>
                <ul className="metismenu" id="menu">
                  <li>
                    <Link to={'/'}>
                      <i className="ti-dashboard" /> <span>DashBoard</span>
                    </Link>
                  </li>
                  <li>
                    <Link to={'/products'}>
                      <i className="ti-dashboard" /> <span>Product</span>
                    </Link>
                  </li>
                  <li>
                    <Link to={'/categories'}>
                      <i className="ti-dashboard" /> <span>Category</span>
                    </Link>
                    {/* <NavButton
                      href="/"
                      content="dashboard"
                      icon="ti-dashboard"
                    /> */}
                  </li>
                  {/* <li>
                    <NavButton href="/" icon="ti-layout-sidebar-left" content="Product" />
                  </li>
                  <li>
                    <NavButton href="/" icon="ti-layout-sidebar-left" content="Category" />
                  </li>
                  <li>
                    <NavButton href="/" icon="ti-pie-chart" content="Charts" />
                  </li>
                  <li>
                    <NavButton href="/" icon="ti-palette" content="UI Features" />
                  </li>
                  <li>
                    <NavButton href="/" icon="ti-slice" content="icons" />
                  </li>
                  <li>
                    <NavButton href="/" icon="fa fa-table" content="Tables" />
                  </li>
                  <li>
                    <NavButton href="maps.html" icon="ti-map-alt" content="maps" />
                  </li>
                  <li>
                    <NavButton href="invoice.html" icon="ti-receipt" content="Invoice Summary" />
                  </li>
                  <li>
                    <NavButton href="/" icon="ti-layers-alt" content="Pages" />
                  </li>
                  <li>
                    <NavButton href="/" icon="fa fa-exclamation-triangle" content="Error" />
                  </li>
                  <li>
                    <NavButton href="/" icon="fa fa-align-left" content="Multi level menu" />
                  </li> */}
                </ul>
              </nav>
            </div>
          </div>
        </div>
      </React.Fragment>
    );
  }
}
