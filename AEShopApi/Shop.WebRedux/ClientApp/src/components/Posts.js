import React, { Component } from 'react';
import PropTypes from 'prop-types';
import { connect } from 'react-redux';
import { fetchPosts } from '../actions/postActions';

class Posts extends Component {
    componentWillMount() {
        //this.props.fetchPosts();
    }
    componentWillReceiveProps(nextProps, nextContext) {
        if (nextProps.newPost) {
            this.props.posts.unshift(nextProps.newPost);
        }
    }

    render() {
        console.log("aaaa");
        console.log(this.props.posts);
        //const postItem = this.props.posts.map((item, index) => (
        //    <div key={index}>
        //        <h3>{item}</h3>
        //    </div>
        //));
        return <div></div>;
    }
}

//Posts.propTypes = {
//    fetchPosts: PropTypes.func.isRequired,
//    posts: PropTypes.array.isRequired,
//};

const mapStateToProps = state => ({
    posts: state.posts.items,
    newPost: state.posts.item
});

export default connect(
    mapStateToProps,
    { fetchPosts }
)(Posts);