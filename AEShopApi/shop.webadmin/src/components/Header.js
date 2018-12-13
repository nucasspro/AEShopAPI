import React, { Component } from 'react';
import author_img1 from '../images/author/author_img1.jpg';
import author_img2 from '../images/author/author_img2.jpg';
import author_img3 from '../images/author/author_img3.jpg';
import author_img4 from '../images/author/author_img4.jpg';

export default class Header extends Component {
  render() {
    return (
      <React.Fragment>
        <div className="row align-items-center">
          <div className="col-md-6 col-sm-8 clearfix">
            <div className="nav-btn pull-left">
              <span /> <span /> <span />
            </div>
            <div className="search-box pull-left">
              <form action="/">
                <input
                  type="text"
                  name="search"
                  placeholder="Search..."
                  required=""
                />
                <i className="ti-search" />
              </form>
            </div>
          </div>
          <div className="col-md-6 col-sm-4 clearfix">
            <ul className="notification-area pull-right">
              <li id="full-view">
                <i className="ti-fullscreen" />
              </li>
              <li id="full-view-exit">
                <i className="ti-zoom-out" />
              </li>
              <li className="dropdown">
                <i className="ti-bell dropdown-toggle" data-toggle="dropdown">
                  <span>2</span>
                </i>
                <div className="dropdown-menu bell-notify-box notify-box">
                  <span className="notify-title">
                    You have 3 new notifications
                    <a href="/">view all</a>
                  </span>
                  <div className="slimScrollDiv">
                    <div className="nofity-list">
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <i className="ti-key btn-danger" />
                        </div>
                        <div className="notify-text">
                          <p>You have Changed Your Password</p>
                          <span>Just Now</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <i className="ti-comments-smiley btn-info" />
                        </div>
                        <div className="notify-text">
                          <p>New Commetns On Post</p>
                          <span>30 Seconds ago</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <i className="ti-key btn-primary" />
                        </div>
                        <div className="notify-text">
                          <p>Some special like you</p>
                          <span>Just Now</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <i className="ti-comments-smiley btn-info" />
                        </div>
                        <div className="notify-text">
                          <p>New Commetns On Post</p>
                          <span>30 Seconds ago</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <i className="ti-key btn-primary" />
                        </div>
                        <div className="notify-text">
                          <p>Some special like you</p>
                          <span>Just Now</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <i className="ti-key btn-danger" />
                        </div>
                        <div className="notify-text">
                          <p>You have Changed Your Password</p>
                          <span>Just Now</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <i className="ti-key btn-danger" />
                        </div>
                        <div className="notify-text">
                          <p>You have Changed Your Password</p>
                          <span>Just Now</span>
                        </div>
                      </a>
                    </div>
                    <div className="slimScrollBar" />
                    <div className="slimScrollRail" />
                  </div>
                </div>
              </li>
              <li className="dropdown">
                <i
                  className="fa fa-envelope-o dropdown-toggle"
                  data-toggle="dropdown"
                >
                  <span>3</span>
                </i>
                <div className="dropdown-menu notify-box nt-enveloper-box">
                  <span className="notify-title">
                    You have 3 new notifications
                    <a href="/">view all</a>
                  </span>
                  <div className="slimScrollDiv">
                    <div className="nofity-list">
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <img src={author_img1} alt="img" />
                        </div>
                        <div className="notify-text">
                          <p>Aglae Mayer</p>
                          <span className="msg">
                            Hey I am waiting for you...
                          </span>
                          <span>3:15 PM</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <img src={author_img2} alt="img" />
                        </div>
                        <div className="notify-text">
                          <p>Aglae Mayer</p>
                          <span className="msg">
                            When you can connect with me...
                          </span>
                          <span>3:15 PM</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <img src={author_img3} alt="img" />
                        </div>
                        <div className="notify-text">
                          <p>Aglae Mayer</p>
                          <span className="msg">I missed you so much...</span>
                          <span>3:15 PM</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <img src={author_img3} alt="img" />
                        </div>
                        <div className="notify-text">
                          <p>Aglae Mayer</p>
                          <span className="msg">
                            Your product is completely Ready...
                          </span>
                          <span>3:15 PM</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <img src={author_img2} alt="img" />
                        </div>
                        <div className="notify-text">
                          <p>Aglae Mayer</p>
                          <span className="msg">
                            Hey I am waiting for you...
                          </span>
                          <span>3:15 PM</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <img src={author_img4} alt="" />
                        </div>
                        <div className="notify-text">
                          <p>Aglae Mayer</p>
                          <span className="msg">
                            Hey I am waiting for you...
                          </span>
                          <span>3:15 PM</span>
                        </div>
                      </a>
                      <a href="/" className="notify-item">
                        <div className="notify-thumb">
                          <img src={author_img3} alt="img" />
                        </div>
                        <div className="notify-text">
                          <p>Aglae Mayer</p>
                          <span className="msg">
                            Hey I am waiting for you...
                          </span>
                          <span>3:15 PM</span>
                        </div>
                      </a>
                    </div>
                  </div>
                </div>
              </li>
              <li className="settings-btn">
                <i className="ti-settings" />
              </li>
            </ul>
          </div>
        </div>
      </React.Fragment>
    );
  }
}
