�}1[  d   ��!��C�u
 xT�
Ro?�p|���r�Y쑆�p����?˞@2-����aXs	���֡����|�C?��/��Å�@��?�� ��Q�@�%a�N뚙\�ۡ�M���d������v�׏�o*�\a�/�Hn��/%�)�$��j�a��ǅ���̜u��am��s^3�A�� �J�}m�����"�.���ȯ���k3]�͉�>�[�+�A�M5R�ȅ�/��I��4j��I ��J#�k~�ˣ�m�
�,��
E)���FB��LTJ2��8��F����,�m�Ѱ�
xɻh
��{��k�{�n;�>���%X�K͂0l�a{�vb�u�c�'BF[��6���X.cTl�A4TK��
����/�W�?�.�XS��g�Jk{������5��$G϶	2���6�p�^A�v�����M-����$u��_�KL�pD�$5t�2�fr>�؉im�I�ѽOM�l�:Rkc�&�y�Z8D��{�5j�pl�%�� L#�]�µ�pc� \�{"���[�a��HNݕ�)2�Z�4��GH�'��d��!���gX�|��_Dr���*��^���`�e�9H�5�"
�nH�e���[�#���z~�v����7�cF��A�+��e�%9&�x+��o
#�3�4��Q%9%���ER�sH�;H���ۇC�ܼN�b�.QK�N��:4U-��]�����C9�60�d|7p��tu
�E"���f��X���]�IQ$�%�Ԁ7�a>BҘH���F��a�`�Gm��0�����)K��L9����З�CضBEv��aq�� �f�C9i��')�ı(dȧZ�<�`}��t��H���C��*�3�
���X)B��R �`����P%i�${h��� 9��կ�<���yΘ�*S\�?i:���p��ǖM�ŉ2��\�,����ш���K�}�4��#)|Z�w�B˭@z�g��-�<�l�`K������24�j��#כ��Ͽ���}

            StringBuilder friendlyPath = new StringBuilder();
            friendlyPath.AppendFormat("{0}-{1}",
                description.HttpMethod.Method,
                localPath.Replace("/", "-").Replace("{", String.Empty).Replace("}", String.Empty));
            if (queryKeyString != null)
            {
                friendlyPath.AppendFormat("_{0}", queryKeyString);
            }
            return friendlyPath.ToString();
        }
    }
}