import React, { Component } from 'react';
import axios from 'axios';

export default class UserTable extends Component {
  state = {
    users: [],
    isLoading: true,
    error: null
  };

  // Call API to get product with asynchronous
  async getUsers() {
    try {
      var response = await axios.get('https://localhost:5001/api/users');

      this.setState({
        users: response.data,
        isLoading: false
      });
    } catch (error) {
      this.setState({
        error: error,
        isLoading: false
      });
      console.log(this.state.error.message);
    }
  }

  componentDidMount() {
    this.getUsers();
  }

  render() {
    const { users } = this.state;

    return <React.Fragment>
        <div className="card">
          <div className="card-body">
            <h4 className="header-title">User Table</h4>
            <div className="data-tables datatable-dark">
              <div id="dataTable3_wrapper" className="dataTables_wrapper dt-bootstrap4 no-footer">
                <div className="row">
                  <div className="col-sm-12 col-md-6">
                    <div className="dataTables_length" id="dataTable3_length">
                      <label>
                        Show <select name="dataTable3_length" aria-controls="dataTable3" className="custom-select custom-select-sm form-control form-control-sm">
                          <option value="10">10</option>
                          <option value="25">25</option>
                          <option value="50">50</option>
                          <option value="100">100</option>
                        </select> entries
                      </label>
                    </div>
                  </div>
                  <div className="col-sm-12 col-md-6">
                    <div id="dataTable3_filter" className="dataTables_filter">
                      <label>
                        Search:
                        <input type="search" className="form-control form-control-sm" placeholder="" aria-controls="dataTable3" />
                      </label>
                    </div>
                  </div>
                </div>
                <div className="row">
                  <div className="col-sm-12">
                    <table id="dataTable3" className="text-center dataTable no-footer dtr-inline w-100" role="grid" aria-describedby="dataTable3_info">
                      <thead className="text-capitalize">
                        <tr role="row">
                          <th className="sorting w-20" tabIndex="0" aria-controls="dataTable3" rowSpan="1" colSpan="1" aria-label="Name: activate to sort column ascending">
                            Name
                          </th>
                          <th className="sorting_desc w-20" tabIndex="0" aria-controls="dataTable3" rowSpan="1" colSpan="1" aria-label="Position: activate to sort column ascending" aria-sort="descending">
                            Position
                          </th>
                          <th className="sorting w-20" tabIndex="0" aria-controls="dataTable3" rowSpan="1" colSpan="1" aria-label="Office: activate to sort column ascending">
                            Office
                          </th>
                          <th className="sorting w-20" tabIndex="0" aria-controls="dataTable3" rowSpan="1" colSpan="1" aria-label="Age: activate to sort column ascending">
                            Age
                          </th>
                          <th className="sorting w-20" tabIndex="0" aria-controls="dataTable3" rowSpan="1" colSpan="1" aria-label="Start Date: activate to sort column ascending">
                            Start Date
                          </th>
                          <th className="sorting w-20" tabIndex="0" aria-controls="dataTable3" rowSpan="1" colSpan="1" aria-label="salary: activate to sort column ascending">
                            salary
                          </th>
                        </tr>
                      </thead>
                      <tbody>
                        {}
                        {users.map((item, index) => (
                          <tr key={index} role="row" className="odd">
                            <td tabIndex="0" className="">
                              {item.userName}
                            </td>
                            <td className="sorting_1">Software Engineer</td>
                            <td>London</td>
                            <td>41</td>
                            <td>2012/10/13</td>
                            <td>$132,000</td>
                          </tr>
                        ))}
                      </tbody>
                    </table>
                  </div>
                </div>
                <div className="row">
                  <div className="col-sm-12 col-md-5">
                    <div className="dataTables_info" id="dataTable3_info" role="status" aria-live="polite">
                      Showing 1 to 10 of 11 entries
                    </div>
                  </div>
                  <div className="col-sm-12 col-md-7">
                    <div className="dataTables_paginate paging_simple_numbers" id="dataTable3_paginate">
                      <ul className="pagination">
                        <li className="paginate_button page-item previous disabled" id="dataTable3_previous">
                          <a href="/" aria-controls="dataTable3" data-dt-idx="0" tabIndex="0" className="page-link">
                            Previous
                          </a>
                        </li>
                        <li className="paginate_button page-item active">
                          <a href="/" aria-controls="dataTable3" data-dt-idx="1" tabIndex="0" className="page-link">
                            1
                          </a>
                        </li>
                        <li className="paginate_button page-item ">
                          <a href="/" aria-controls="dataTable3" data-dt-idx="2" tabIndex="0" className="page-link">
                            2
                          </a>
                        </li>
                        <li className="paginate_button page-item next" id="dataTable3_next">
                          <a href="/" aria-controls="dataTable3" data-dt-idx="3" tabIndex="0" className="page-link">
                            Next
                          </a>
                        </li>
                      </ul>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </React.Fragment>;
  }
}
