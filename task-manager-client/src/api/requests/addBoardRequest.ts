import axios, { AxiosResponse } from 'axios';
import API_ROUTES from '../apiRoutes';

function addBoardRequest(title: string): Promise<AxiosResponse<void>> {
  return axios.post<void>(API_ROUTES.boardUrl, '"' + title.trim() + '"');
}

export default addBoardRequest;
