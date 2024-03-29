import axios, { AxiosResponse } from 'axios';
import API_ROUTES from '../apiRoutes';

function removeCardRequest(cardId: number): Promise<AxiosResponse<void>> {
  return axios.delete<void>(API_ROUTES.cardUrl + '/' + cardId);
}

export default removeCardRequest;
