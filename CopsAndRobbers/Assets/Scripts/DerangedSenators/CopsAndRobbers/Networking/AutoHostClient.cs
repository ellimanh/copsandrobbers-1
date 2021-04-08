/* 
 *  Copyright (C) 2021 Deranged Senators
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *  
 *      http:www.apache.org/licenses/LICENSE-2.0
 *  
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

using Mirror;
using UnityEngine;

namespace DerangedSenators.CopsAndRobbers.Networking
{
    public class AutoHostClient : NetworkBehaviour
    {
        [SerializeField] private NetworkManager networkManager;

        private void Start()
        {
            if (Application.isBatchMode) //Headless Build for Server 
            {
                //*Debug.Log($"=== Server Build Starting ===");
            }
            else
            {
                //*Debug.Log($"<color=yellow>=== Client Build Starting ===</color>");
                networkManager.StartClient();
            }
        }

        public void JoinLocal()
        {
            networkManager.networkAddress = "localhost";
            networkManager.StartClient();
        }
    }
}