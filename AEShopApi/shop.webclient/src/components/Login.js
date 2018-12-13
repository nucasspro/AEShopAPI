import React, { Component } from 'react';
import { Button, Form, FormGroup, Label, Input } from 'reactstrap';

export default class Login extends Component {
  render() {
    return (
      <Form>
        <FormGroup>
          <Label for="Username">Tên đăng nhập</Label>
          <Input
            type="username"
            name="username"
            id="username"
            placeholder="Nhập tên đăng nhập"
          />
        </FormGroup>
        <FormGroup>
          <Label for="Password">Mật khẩu</Label>
          <Input
            type="password"
            name="password"
            id="Password"
            placeholder="Nhập mật khẩu"
          />
        </FormGroup>
        <Button color="primary" size="lg">
          Đăng nhập!
        </Button>{' '}
      </Form>
    );
  }
}
