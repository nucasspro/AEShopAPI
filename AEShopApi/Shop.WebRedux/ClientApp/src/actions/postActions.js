import { FETCH_POSTS, NEW_POST } from './types';
import axios from 'axios';

export const fetchPosts = () => dispatch => {
    axios.get('api/home/getall')
        .then(function (response) {
            dispatch({ type: FETCH_POSTS, posts: response })
        })
        .catch(function (error) {
            console.log(error);
        });
};

export const createPost = postData => dispatch => {
    fetch('https://jsonplaceholder.typicode.com/users', {
        method: 'POST',
        headers: { 'content-type': 'application/json' },
        body: JSON.stringify(postData)
    })
        .then(response => response.json())
        .then(post => dispatch({ type: NEW_POST, post: post }));
};