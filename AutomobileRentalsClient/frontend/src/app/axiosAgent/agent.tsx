import axios, { AxiosResponse } from "axios";

axios.defaults.url = "http://localhost:5065/api/";
axios.defaults.withCredentials = true;
axios.defaults.timeout = 30000; //30 seconds timeout

const response = (response: AxiosResponse) => response.data;

const request = {
  get: (url: string, params?: URLSearchParams) =>
    axios.get(url, { params }).then(response),
  post: (url: string, data: object) => axios.post(url, data).then(response),
  put: (url: string, data: object) => axios.put(url, data).then(response),
  delete: (url: string, data: object) =>
    axios.delete(url, { data }).then(response),
};

const account = {
  login: (data: object) => request.post("account/login", data),
};

const agent = {
  account,
};

export default agent;
